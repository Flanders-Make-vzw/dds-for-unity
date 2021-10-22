/* 
 Copyright 2020 Edward Hage

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using Unity.Collections;
using sensor_msgs;
using sensor_msgs.msg.dds_;

[RequireComponent(typeof(Camera))]
public class CameraJpegPub : MonoBehaviour
{
    private Queue<AsyncGPUReadbackRequest> requests = new Queue<AsyncGPUReadbackRequest>();

    public float timeBetweenRequests = 0.2f;
    public string topicname = "rt/jaja/image_raw/compressed";
    public string frame_id = null;
    [Range(0, 100)]
    public int JpgQuality = 50;

    private Camera MyCamera;
    private CompressedImagePublisher ImagePub;
    private Texture2D tex;
    private RenderTexture m_RenderTexture;
    private float timer = 0.0f;
    private CompressedImage_ myimage = new CompressedImage_ { format_ = "jpeg" };

    void Start()
    {
        ImagePub = new CompressedImagePublisher(topicname);

        MyCamera = GetComponent<Camera>();
        MyCamera.pixelRect = new Rect(0, 0, 512, 512);
        MyCamera.rect = new Rect(0f, 0f, 1f, 1f);
        // create RenderTexture and assign it to the main camera
        m_RenderTexture = new RenderTexture(MyCamera.pixelWidth, MyCamera.pixelHeight, 24, RenderTextureFormat.ARGB32); // original : ARGB32
        m_RenderTexture.name = "ROStexture";
        m_RenderTexture.Create();
        MyCamera.targetTexture = m_RenderTexture;
        //MyCamera.rect = new Rect(0f, 0f, 1f, 1f);
        MyCamera.Render();

        tex = new Texture2D(MyCamera.pixelWidth, MyCamera.pixelHeight, TextureFormat.BGRA32, false);
        Debug.Log("0In start END, camsize width:" + MyCamera.pixelWidth.ToString() + " height:" + MyCamera.pixelHeight.ToString());
    }

    void Update()
    {
        // Handle Request Queue
        while (requests.Count > 0)
        {
            // Get the first Request in the Queue
            AsyncGPUReadbackRequest request = requests.Peek();
            if (request.hasError)
            {
                // Error!
                Debug.LogWarning("AsyncGPUReadbackRequest Error! :(");
                requests.Dequeue(); // Remove from Queue
            }
            else if (request.done)
            {
                ReadbackData(request);
                requests.Dequeue(); // Remove from Queue
            }
            else
            {
                // Request is still processing.
                break;
            }
            // Note : We have to Dequeue items or break,
            // or we'll be caught in an infinite loop!
        }

        // Handle Request Timer
        timer += Time.deltaTime;
        if (timer > timeBetweenRequests)
        {
            timer = timer - timeBetweenRequests;
            AsyncGPUReadbackRequest rq = AsyncGPUReadback.Request(m_RenderTexture);
            requests.Enqueue(rq);
        }
    }

    void ReadbackData(AsyncGPUReadbackRequest request)
    {
        //tex = new Texture2D(512, 512, TextureFormat.BGRA32, false); //BGRSA32 dan kleuren okay, niet voor RGBA32 (blauw en rood omgedraaid)
        // warom nieuwe tex, die is al gedefinieerd bij Start? dus weggehaald
        int len = request.GetData<Color32>().ToArray().Length;

        Debug.Log("Got a AsyncGPUReadbackRequest with size " + len.ToString() + " and require size " + (MyCamera.pixelWidth * MyCamera.pixelHeight).ToString() + ", discarding it");
        Debug.Log("camsize width:" + MyCamera.pixelWidth.ToString() + " height:" + MyCamera.pixelHeight.ToString());

        tex.SetPixels32(request.GetData<Color32>().ToArray());
        tex.Apply();

        myimage.data_ = tex.EncodeToJPG(JpgQuality);
        myimage.header_.stamp_ = ros_helper.RosHelper.GetUnixTimestamp();
        myimage.header_.frame_id_ = frame_id;
        ImagePub.Publish(myimage); // dit duurt waarschijnlijk zo lang
    }

    private void OnDisable()
    {
        ImagePub.Cleanup();
    }
}

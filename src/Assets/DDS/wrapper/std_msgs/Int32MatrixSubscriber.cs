using DDS;
using DDSAPIHelper;

using std_msgs.msg.dds_;

namespace std_msgs
{
    public class Int32MatrixSubscriber
    {
        private DDSEntityManager mgr;
        private Int32MultiArray_TypeSupport msgTS = new Int32MultiArray_TypeSupport();
        private ReturnCode status;
        public Int32MultiArray_[] msgSeq = null;
        public Int32MultiArray_ lastmessage = new Int32MultiArray_();
        private DDS.SampleInfo[] infoSeq = null;
        private Int32MultiArray_DataReader DataReader;
        private IDataReader dreader;
        public string topicname;

        public Int32MatrixSubscriber(string topicname)
        {
            this.topicname = topicname;
            mgr = new DDSEntityManager("ROS");
            mgr.createParticipant("");
            mgr.setAutoDispose(false);
            mgr.registerType(msgTS);
            mgr.createTopic(topicname);
            mgr.createSubscriber();
            mgr.createReader(false);

            dreader = mgr.getReader();
            DataReader = dreader as Int32MultiArray_DataReader;
        }

        public Int32MultiArray_ GetMessage()
        {
            status = DataReader.Take(ref msgSeq, ref infoSeq, Length.Unlimited, SampleStateKind.Any, ViewStateKind.Any, InstanceStateKind.Any);
            ErrorHandler.checkStatus(status, "DataReader.Take");
            // this is effective a polling action of all the missed messages, only interested in the last
            if (msgSeq.Length > 0)
            {
                if (infoSeq[msgSeq.Length - 1].ValidData)
                {
                    lastmessage = msgSeq[msgSeq.Length - 1];
                }
            }
            status = DataReader.ReturnLoan(ref msgSeq, ref infoSeq);
            ErrorHandler.checkStatus(status, "DataReader.ReturnLoan");
            return lastmessage;
        }

        public int[,] GetMatrix()
        {
            GetMessage(); // this gets: lastmessage
            uint n = lastmessage.layout_.dim_[0].size_;
            uint m = lastmessage.layout_.dim_[1].size_;
            int[,] matrix = new int[n, m];
            for (uint i = 0; i < n; i++)
            {
                for (uint j = 0; i < m; j++)
                {
                    matrix[i, j] = lastmessage.data_[lastmessage.layout_.data_offset_ + lastmessage.layout_.dim_[1].stride_ * i + j];
                }
            }

            return matrix;
        }

        public void Cleanup()
        {
            mgr.getSubscriber().DeleteDataReader(DataReader);
            mgr.deleteSubscriber();
            mgr.deleteTopic();
            mgr.deleteParticipant();
        }
    }
}



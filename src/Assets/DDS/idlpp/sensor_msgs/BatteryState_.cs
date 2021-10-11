using DDS;
using System.Runtime.InteropServices;

namespace sensor_msgs
{
    namespace msg
    {
        namespace dds_
        {
            namespace BatteryState_Constants
            {
                public struct POWER_SUPPLY_STATUS_UNKNOWN_ { public static readonly byte value = (byte) 0; }

                public struct POWER_SUPPLY_STATUS_CHARGING_ { public static readonly byte value = (byte) 1; }

                public struct POWER_SUPPLY_STATUS_DISCHARGING_ { public static readonly byte value = (byte) 2; }

                public struct POWER_SUPPLY_STATUS_NOT_CHARGING_ { public static readonly byte value = (byte) 3; }

                public struct POWER_SUPPLY_STATUS_FULL_ { public static readonly byte value = (byte) 4; }

                public struct POWER_SUPPLY_HEALTH_UNKNOWN_ { public static readonly byte value = (byte) 0; }

                public struct POWER_SUPPLY_HEALTH_GOOD_ { public static readonly byte value = (byte) 1; }

                public struct POWER_SUPPLY_HEALTH_OVERHEAT_ { public static readonly byte value = (byte) 2; }

                public struct POWER_SUPPLY_HEALTH_DEAD_ { public static readonly byte value = (byte) 3; }

                public struct POWER_SUPPLY_HEALTH_OVERVOLTAGE_ { public static readonly byte value = (byte) 4; }

                public struct POWER_SUPPLY_HEALTH_UNSPEC_FAILURE_ { public static readonly byte value = (byte) 5; }

                public struct POWER_SUPPLY_HEALTH_COLD_ { public static readonly byte value = (byte) 6; }

                public struct POWER_SUPPLY_HEALTH_WATCHDOG_TIMER_EXPIRE_ { public static readonly byte value = (byte) 7; }

                public struct POWER_SUPPLY_HEALTH_SAFETY_TIMER_EXPIRE_ { public static readonly byte value = (byte) 8; }

                public struct POWER_SUPPLY_TECHNOLOGY_UNKNOWN_ { public static readonly byte value = (byte) 0; }

                public struct POWER_SUPPLY_TECHNOLOGY_NIMH_ { public static readonly byte value = (byte) 1; }

                public struct POWER_SUPPLY_TECHNOLOGY_LION_ { public static readonly byte value = (byte) 2; }

                public struct POWER_SUPPLY_TECHNOLOGY_LIPO_ { public static readonly byte value = (byte) 3; }

                public struct POWER_SUPPLY_TECHNOLOGY_LIFE_ { public static readonly byte value = (byte) 4; }

                public struct POWER_SUPPLY_TECHNOLOGY_NICD_ { public static readonly byte value = (byte) 5; }

                public struct POWER_SUPPLY_TECHNOLOGY_LIMN_ { public static readonly byte value = (byte) 6; }

            }

            #region BatteryState_
            [StructLayout(LayoutKind.Sequential)]
            public sealed class BatteryState_
            {
                public std_msgs.msg.dds_.Header_ header_ = new std_msgs.msg.dds_.Header_();
                public float voltage_;
                public float temperature_;
                public float current_;
                public float charge_;
                public float capacity_;
                public float design_capacity_;
                public float percentage_;
                public byte power_supply_status_;
                public byte power_supply_health_;
                public byte power_supply_technology_;
                public bool present_;
                public float[] cell_voltage_ = new float[0];
                public float[] cell_temperature_ = new float[0];
                public string location_ = string.Empty;
                public string serial_number_ = string.Empty;
            };
            #endregion

        }

    }

}


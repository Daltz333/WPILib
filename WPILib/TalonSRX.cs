﻿using WPILib.Interfaces;
using HAL_Base;

namespace WPILib
{
    public class TalonSRX : SafePWM, SpeedController
    {
        private void InitTalonSRX()
        {
            SetBounds(2.004, 1.52, 1.50, 1.48, .997);
            SetPeriodMultiplier(PeriodMultiplier.K1X);
            SetRaw(GetCenterPwm());
            SetZeroLatch();

            HAL.Report(ResourceType.kResourceType_Talon, (byte)GetChannel());
        }

        public TalonSRX(int channel)
            : base(channel)
        {
            InitTalonSRX();
        }


        public void PidWrite(double output)
        {
            Set(output);
        }

        public double Get()
        {
            return GetSpeed();
        }

        public void Set(double speed, byte syncGroup)
        {
            SetSpeed(speed);
            Feed();
        }

        public void Set(double speed)
        {
            SetSpeed(speed);
            Feed();
        }
    }
}
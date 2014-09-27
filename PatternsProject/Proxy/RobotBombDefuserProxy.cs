using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy
{
    class RobotBombDefuserProxy : RobotBombDefuser
    {
        private RobotBombDefuser _robotBombDefuser;
        private int _communicationWaveLength;
        private int _connectionsAttemps = 3;

        public RobotBombDefuserProxy(int _communicationWaveLength)
        {
            this._communicationWaveLength = _communicationWaveLength;
            _robotBombDefuser = new RobotBombDefuser();
        }

        public override void WalkStraightForward(int steps)
        {
            this.EnsureConnection();
            _robotBombDefuser.WalkStraightForward(steps);
        }

        public override void TurnLeft()
        {
            this.EnsureConnection();
            _robotBombDefuser.TurnLeft();
        }

        public override void TurnRight()
        {
            this.EnsureConnection();
            _robotBombDefuser.TurnRight();
        }

        public override void DefuseBomb()
        {
            this.EnsureConnection();
            _robotBombDefuser.DefuseBomb();
        }

        private void EnsureConnection()
        {
            if (_robotBombDefuser == null)
            {
                _robotBombDefuser = new RobotBombDefuser();
                _robotBombDefuser.ConnectWireless(_communicationWaveLength);
            }
            for (int i = 0; i < _connectionsAttemps; i++)
            {
                if (_robotBombDefuser.IsConnected() != true)
                {
                    _robotBombDefuser.ConnectWireless(_communicationWaveLength);
                }
                else
                {
                    break;
                }
                if (_robotBombDefuser.IsConnected() != true)
                {
                    throw new BadConnectionException("No Connection");
                }
            }
        }
    }
}

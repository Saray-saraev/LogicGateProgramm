
using LogicProject.Moduls.GateLogic.Interfaces;

namespace LogicProject.Moduls.GateLogic.IOGates
{
    internal class InputPort : IInputPort
    {
        private bool signal;
        private IOutputPort? Connection { get; set; }
        public bool IsConnected { get; set; }
        public void Connect(IPort Port)
        {
            IsConnected = true;
            Connection = (IOutputPort)Port;
        }
        public void Disconnect()
        {
            IsConnected = false;
            Connection = null;
        }
        public void GetSignal(bool Signal)
        {
            signal = Signal;
        }
    }
}

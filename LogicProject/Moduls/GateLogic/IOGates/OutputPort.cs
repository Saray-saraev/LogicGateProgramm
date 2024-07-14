
using LogicProject.Moduls.GateLogic.Interfaces;

namespace LogicProject.Moduls.GateLogic.IOGates
{
    internal class OutputPort : IOutputPort
    {
        private bool signal;
        private IInputPort? Connection { get; set; }
        public bool IsConnected { get; set; }
        public void Connect(IPort Port)
        {
            IsConnected = true;
            Connection = (IInputPort)Port;
        }
        public void Disconnect()
        {
            IsConnected = false;
            Connection = null;
        }
        public void SendSignal()
        {
            Connection.GetSignal(signal);
        }
    }
}

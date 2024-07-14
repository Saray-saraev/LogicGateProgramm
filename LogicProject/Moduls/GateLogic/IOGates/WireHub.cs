
using LogicProject.Moduls.GateLogic.Interfaces;

namespace LogicProject.Moduls.GateLogic.IOGates
{
    internal class WireHub : IOutputPort, IInputPort
    {
        bool signal;
        public bool IsConnected { get; set; }
        List<IInputPort> InputConnections;
        List<IOutputPort> OutputConnections;

        public void Connect(IPort Port)
        {
            Type PortType = Port.GetType();
            foreach(Type portInterface in PortType.GetInterfaces())
            {
                if(portInterface.Name == "IOutputPort") 
                {
                    IsConnected = true;
                    OutputConnections.Add((IOutputPort)Port);
                }
                if(portInterface.Name == "IInputPort")
                {
                    IsConnected = true;
                    InputConnections.Add((IInputPort)Port);
                }
            }
        }
        public void Disconnect(IPort Port)
        {
            Type PortType = Port.GetType();
            foreach (Type portInterface in PortType.GetInterfaces())
            {
                if (portInterface.Name == "IOutputPort")
                {
                    
                    OutputConnections.Remove((IOutputPort)Port);
                }
                if (portInterface.Name == "IInputPort")
                {
                    InputConnections.Remove((IInputPort)Port);
                }
            }
        }
        
        public void SendSignal()
        {
            foreach(IInputPort InputPort in InputConnections)
            {
                InputPort.GetSignal(signal);

            }
        }
        public void GetSignal(bool Signal)
        {
            signal = Signal;
        }
    }
}

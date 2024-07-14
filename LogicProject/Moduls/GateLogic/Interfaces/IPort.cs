
namespace LogicProject.Moduls.GateLogic.Interfaces
{
    internal interface IPort
    {
        public bool IsConnected { get; set; }
        public void Connect(IPort Port);
        public void Disconnect() { }
    }
}

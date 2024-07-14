
namespace LogicProject.Moduls.GateLogic.Interfaces
{
    internal interface IPort
    {
        public bool IsConnected { get; set; }
        public void Connect(params IPort[] Ports);
    }
}

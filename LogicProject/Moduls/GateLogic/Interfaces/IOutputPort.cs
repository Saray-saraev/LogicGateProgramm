
namespace LogicProject.Moduls.GateLogic.Interfaces
{
    internal interface IOutputPort : IPort
    {
        public bool SendSignal(bool signal);
    }
}

using VRage;
using VRage.Plugins;

namespace DisableSpectatorMouseSensitivity
{
    public class DisableSpectatorMouseSensitivity : IPlugin
    {
        public void Init(object gameInstance) { }
        public void Update() {
            if (MySpectator.Static != null)
                MySpectator.Static.SpeedModeAngular = 1;
        }
        public void Dispose() { } 
    }
}

using PostSharp.Aspects;
using System;
using System.Diagnostics;
using System.Reflection;

namespace DevFrameWork.Core.Aspects.Postsharp.PerformanceAspects
{
    [Serializable]
    public class PerformanceCounterAspect : OnMethodBoundaryAspect
    {
        // Mettotun çalışma süresini ölçmek için kullanılan değişken
        private int _interval;
        [NonSerialized]
        private Stopwatch _stopwatch;

        public PerformanceCounterAspect(int interval = 5)
        {
            _interval = interval;
        }

        public override void RuntimeInitialize(MethodBase method)
        {
            _stopwatch = Activator.CreateInstance<Stopwatch>();
        }

        public override void OnEntry(MethodExecutionArgs args)
        {
            _stopwatch.Start();
            base.OnEntry(args);
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            _stopwatch?.Stop();
            if (_stopwatch.Elapsed.TotalSeconds > _interval)
            {
                // Loglama yapılabilir, veya mail attırılabilir ihtiyaca göre burası değiştirilebilir.
                Debug.WriteLine("Performece : {0}, {1}->>{2}", args.Method.DeclaringType.FullName, args.Method.Name, _stopwatch.Elapsed.TotalSeconds);
            }
            _stopwatch.Reset();
            base.OnExit(args);
        }
    }
}

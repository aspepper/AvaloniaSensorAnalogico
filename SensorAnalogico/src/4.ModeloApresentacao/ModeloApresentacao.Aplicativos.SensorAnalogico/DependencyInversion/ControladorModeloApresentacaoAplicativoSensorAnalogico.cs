using System.Collections.Generic;
using Verion.Infraestrutura.Dependency;
using Verion.Maquina.Controladores.ModeloAplicacao.SensorAnalogico.DependencyInversion;

namespace Verion.Maquina.Controladores.ModeloApresentacao.Aplicativos.SensorAnalogico.DependencyInversion
{
    public sealed class ControladorModeloApresentacaoAplicativoSensorAnalogico : ImmutableContainerBuilder
    {
        public ControladorModeloApresentacaoAplicativoSensorAnalogico()
            : base(GetRegistrations())
        {
        }

        private static IEnumerable<ContainerRegistration> GetRegistrations()
        {
            yield return CreateSingleton<ControladorModeloAplicacaoSensorAnalogico>();
        }
    }
}
using System.Collections.Generic;
using Verion.Infraestrutura.Dependency;

namespace Verion.Maquina.Controladores.ModeloAplicacao.SensorAnalogico.DependencyInversion
{
    public sealed class ControladorModeloAplicacaoSensorAnalogico : ImmutableContainerBuilder
    {
        public ControladorModeloAplicacaoSensorAnalogico()
            : base(GetRegistrations())
        {
        }

        private static IEnumerable<ContainerRegistration> GetRegistrations()
        {
            //yield return CreateSingleton<ModeloAplicacaoControladorNulo>();
        }
    }
}
using System.Collections.Generic;
using Verion.Infraestrutura.Dependency;
using Verion.Maquina.Controladores.Modelo.SensorAnalogico;

namespace Verion.Maquina.Controladores.Modelo.SensorAnalogico.DependencyInversion
{
    public sealed class ControladorModeloSensorAnalogico : ImmutableContainerBuilder
    {
        public ControladorModeloSensorAnalogico()
            : base(ObterRegistros().WithAbstractions())
        {
        }

        private static IEnumerable<ContainerRegistration> ObterRegistros()
        {
            //yield return CreateSingleton<ServicoControladorEspecificoSensorAnalogicoFabrica>();
            //yield return CreateSingleton<ServicoControladorSensorAnalogicoNenhum>();
        }
    }
}
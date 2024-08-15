using FluentAssertions;
using MediatR;
using NetArchTest.Rules;

namespace YourCarSlot.Application.ArchitectureTests.CommandHandlers;

public sealed class CommandHandlerArchitectureTests
{
    [Fact]
    public void ApplicationLayer_CommandHandlers_ShouldBeSealed()
    {
        var assemblies = AppDomain.CurrentDomain.GetAssemblies()
            .Where(x => x.FullName!
            .Contains("YourCarSlot.Application"))
            .Where(x => !x.FullName!.Contains("Tests"))
            .FirstOrDefault();

        var result = Types.InAssembly(assemblies)
            .That()
            .ImplementInterface(typeof(IRequestHandler<,>))
            .Should()
            .BeSealed()
            .GetResult();

        result.IsSuccessful.Should().BeTrue();
    }
}
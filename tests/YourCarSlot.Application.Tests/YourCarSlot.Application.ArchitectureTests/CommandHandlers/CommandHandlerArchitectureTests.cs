using FluentAssertions;
using MediatR;
using NetArchTest.Rules;

namespace YourCarSlot.Application.ArchitectureTests.CommandHandlers;

public sealed class CommandHandlerArchitectureTests
{
    // private static readonly Assembly _applictaionAssembly = Assembly.GetAssembly().Where();

    [Fact]
    public void ApplicationCommandsShouldBeSealed()
    {
        var allAssemblies = AppDomain.CurrentDomain.GetAssemblies();
        var assemblies = AppDomain.CurrentDomain.GetAssemblies().Where(x => x.FullName!.Equals("YourCarSlot.Application")).FirstOrDefault();
        var result = Types.InAssembly(assemblies)
            .That()
            .ImplementInterface(typeof(IRequestHandler<, >))
            .Should()
            .BeSealed()
            .GetResult();

        result.IsSuccessful.Should().BeTrue(); 

    }
}
using KempDec.StarterDotNet.Blazor.JSInterops;
using Microsoft.AspNetCore.Components;

namespace StarterDotNet.Sample.Components.Pages;

public partial class Home
{
    /// <summary>
    /// Obt�m ou inicializa o respons�vel pela interopabilidade JavaScript do StarterDotNet.
    /// </summary>
    [Inject]
    private StarterJSInterop JS { get; init; } = null!;
}

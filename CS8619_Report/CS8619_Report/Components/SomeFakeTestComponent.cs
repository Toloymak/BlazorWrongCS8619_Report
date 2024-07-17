using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace CS8619_Report.Components;

#nullable disable
public class SomeFakeTestComponent<T> : ComponentBase
{
    [Parameter]
    public T Value { get; set; }
    
    [Parameter]
    public EventCallback<T> ValueChanged { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.AddContent(0, $"Some content: {Value}");
    }
}

#nullable enable
public record RandomClass
{
    public string SomeValue { get; set; } = "1";
}
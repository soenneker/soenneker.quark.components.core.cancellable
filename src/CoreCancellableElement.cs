using Microsoft.AspNetCore.Components;
using Soenneker.Quark.Components.Core.Cancellable.Abstract;

namespace Soenneker.Quark.Components.Core.Cancellable;

///<inheritdoc cref="ICoreCancellableElement"/>
public abstract class CoreCancellableElement : CoreCancellableComponent, ICoreCancellableElement
{
    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}
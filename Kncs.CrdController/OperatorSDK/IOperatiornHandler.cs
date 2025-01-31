﻿// Copied from https://github.com/ContainerSolutions/dotnet-operator-sdk

using k8s;

namespace Kncs.CrdController.OperatorSDK;

public interface IOperationHandler<T> where T : BaseCRD
{
    Task OnAdded(Kubernetes k8s, T crd);

    Task OnDeleted(Kubernetes k8s, T crd);

    Task OnUpdated(Kubernetes k8s, T crd);

    Task OnBookmarked(Kubernetes k8s, T crd);

    Task OnError(Kubernetes k8s, T crd);

    Task CheckCurrentState(Kubernetes k8s);
}
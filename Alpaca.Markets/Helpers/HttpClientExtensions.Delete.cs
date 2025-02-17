﻿namespace Alpaca.Markets;

internal static partial class HttpClientExtensions
{
    public static Task<Boolean> TryDeleteAsync(
        this HttpClient httpClient,
        UriBuilder uriBuilder,
        CancellationToken cancellationToken) =>
        callAndReturnSuccessCodeAsync(
            httpClient, HttpMethod.Delete, uriBuilder.Uri, cancellationToken);

    public static Task<Boolean> TryDeleteAsync(
        this HttpClient httpClient,
        String endpointUri,
        CancellationToken cancellationToken) =>
        callAndReturnSuccessCodeAsync(
            httpClient, HttpMethod.Delete, asUri(endpointUri), cancellationToken);

    public static Task<TApi> DeleteAsync<TApi, TJson>(
        this HttpClient httpClient,
        UriBuilder uriBuilder,
        CancellationToken cancellationToken)
        where TJson : TApi =>
        callAndDeserializeAsync<TApi, TJson>(
            httpClient, HttpMethod.Delete, uriBuilder.Uri, cancellationToken);

    public static Task<TApi> DeleteAsync<TApi, TJson>(
        this HttpClient httpClient,
        UriBuilder uriBuilder,
        TimeSpan timeout,
        CancellationToken cancellationToken)
        where TJson : TApi =>
        callAndDeserializeAsync<TApi, TJson>(
            httpClient, HttpMethod.Delete, uriBuilder.Uri, timeout, cancellationToken);

    public static Task<TApi> DeleteAsync<TApi, TJson>(
        this HttpClient httpClient,
        String endpointUri,
        CancellationToken cancellationToken)
        where TJson : TApi =>
        callAndDeserializeAsync<TApi, TJson>(
            httpClient, HttpMethod.Delete, asUri(endpointUri), cancellationToken);
}

// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TelemetryBatch.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Library.Inputs.Contracts {
  /// <summary>
  /// gRPC service to transmit telemetry
  /// </summary>
  public static partial class TelemetryService
  {
    static readonly string __ServiceName = "contracts.TelemetryService";

    static readonly grpc::Marshaller<global::Library.Inputs.Contracts.TelemetryBatch> __Marshaller_TelemetryBatch = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Library.Inputs.Contracts.TelemetryBatch.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Library.Inputs.Contracts.Response> __Marshaller_Response = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Library.Inputs.Contracts.Response.Parser.ParseFrom);

    static readonly grpc::Method<global::Library.Inputs.Contracts.TelemetryBatch, global::Library.Inputs.Contracts.Response> __Method_SendTelemetryBatch = new grpc::Method<global::Library.Inputs.Contracts.TelemetryBatch, global::Library.Inputs.Contracts.Response>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "SendTelemetryBatch",
        __Marshaller_TelemetryBatch,
        __Marshaller_Response);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Library.Inputs.Contracts.TelemetryBatchReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of TelemetryService</summary>
    public abstract partial class TelemetryServiceBase
    {
      public virtual global::System.Threading.Tasks.Task SendTelemetryBatch(grpc::IAsyncStreamReader<global::Library.Inputs.Contracts.TelemetryBatch> requestStream, grpc::IServerStreamWriter<global::Library.Inputs.Contracts.Response> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for TelemetryService</summary>
    public partial class TelemetryServiceClient : grpc::ClientBase<TelemetryServiceClient>
    {
      /// <summary>Creates a new client for TelemetryService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public TelemetryServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for TelemetryService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public TelemetryServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected TelemetryServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected TelemetryServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual grpc::AsyncDuplexStreamingCall<global::Library.Inputs.Contracts.TelemetryBatch, global::Library.Inputs.Contracts.Response> SendTelemetryBatch(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SendTelemetryBatch(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Library.Inputs.Contracts.TelemetryBatch, global::Library.Inputs.Contracts.Response> SendTelemetryBatch(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_SendTelemetryBatch, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override TelemetryServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new TelemetryServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(TelemetryServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SendTelemetryBatch, serviceImpl.SendTelemetryBatch).Build();
    }

  }
}
#endregion

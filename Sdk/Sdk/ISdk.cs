﻿namespace Stratumn.Sdk
{
    using System.Threading.Tasks;
    using Stratumn.Sdk.Model.Trace;

    /// <summary>
    /// Defines the <see cref="ISdk{TState}" />
    /// </summary>
    /// <typeparam name="TState"></typeparam>
    public interface ISdk<TState>
    {
        /// <summary>
        /// The NewTrace
        /// </summary>
        /// <typeparam name="TLinkData"></typeparam>
        /// <param name="input">The input<see cref="NewTraceInput{TLinkData}"/></param>
        /// <returns>The <see cref="TraceState{TState, TLinkData}"/></returns>
         Task<TraceState<TState, TLinkData>> NewTraceAsync<TLinkData>(NewTraceInput<TLinkData> input);

        /// <summary>
        /// The AppendLink
        /// </summary>
        /// <typeparam name="TLinkData"></typeparam>
        /// <param name="input">The input<see cref="AppendLinkInput{TLinkData}"/></param>
        /// <returns>The <see cref="TraceState{TState, TLinkData}"/></returns>
         Task<TraceState<TState, TLinkData>> AppendLinkAsync<TLinkData>(AppendLinkInput<TLinkData> input);

        /// <summary>
        /// The PushTrace
        /// </summary>
        /// <typeparam name="TLinkData"></typeparam>
        /// <param name="input">The input<see cref="PushTransferInput{TLinkData}"/></param>
        /// <returns>The <see cref="TraceState{TState, TLinkData}"/></returns>
         Task<TraceState<TState, TLinkData>> PushTraceAsync<TLinkData>(PushTransferInput<TLinkData> input);

        /// <summary>
        /// The PullTrace
        /// </summary>
        /// <typeparam name="TLinkData"></typeparam>
        /// <param name="input">The input<see cref="PullTransferInput{TLinkData}"/></param>
        /// <returns>The <see cref="TraceState{TState, TLinkData}"/></returns>
         Task<TraceState<TState, TLinkData>> PullTraceAsync<TLinkData>(PullTransferInput<TLinkData> input);

        /// <summary>
        /// The AcceptTransfer
        /// </summary>
        /// <typeparam name="TLinkData"></typeparam>
        /// <param name="input">The input<see cref="TransferResponseInput{TLinkData}"/></param>
        /// <returns>The <see cref="TraceState{TState, TLinkData}"/></returns>
        Task<TraceState<TState, TLinkData>> AcceptTransferAsync<TLinkData>(TransferResponseInput<TLinkData> input);

        /// <summary>
        /// The RejectTransfer
        /// </summary>
        /// <typeparam name="TLinkData"></typeparam>
        /// <param name="input">The input<see cref="TransferResponseInput{TLinkData}"/></param>
        /// <returns>The <see cref="TraceState{TState, TLinkData}"/></returns>
        Task<TraceState<TState, TLinkData>> RejectTransferAsync<TLinkData>(TransferResponseInput<TLinkData> input);

        /// <summary>
        /// The CancelTransfer
        /// </summary>
        /// <typeparam name="TLinkData"></typeparam>
        /// <param name="input">The input<see cref="TransferResponseInput{TLinkData}"/></param>
        /// <returns>The <see cref="TraceState{TState, TLinkData}"/></returns>
        Task<TraceState<TState, TLinkData>> CancelTransferAsync<TLinkData>(TransferResponseInput<TLinkData> input);

        /// <summary>
        /// The GetTraceState
        /// </summary>
        /// <typeparam name="TLinkData"></typeparam>
        /// <param name="input">The input<see cref="GetTraceStateInput"/></param>
        /// <returns>The <see cref="TraceState{TState, TLinkData}"/></returns>
         Task<TraceState<TState, TLinkData>> GetTraceStateAsync<TLinkData>(GetTraceStateInput input);

        /// <summary>
        /// The GetTraceDetails
        /// </summary>
        /// <typeparam name="TLinkData"></typeparam>
        /// <param name="input">The input<see cref="GetTraceDetailsInput"/></param>
        /// <returns>The <see cref="TraceDetails{TLinkData}"/></returns>
        Task<TraceDetails<TLinkData>> GetTraceDetailsAsync<TLinkData>(GetTraceDetailsInput input);

        /// <summary>
        /// The GetIncomingTraces
        /// </summary>
        /// <typeparam name="TLinkData"></typeparam>
        /// <param name="paginationInfo">The paginationInfo<see cref="PaginationInfo"/></param>
        /// <returns>The <see cref="TracesState{TState, TLinkData}"/></returns>
        Task<TracesState<TState, TLinkData>> GetIncomingTracesAsync<TLinkData>(PaginationInfo paginationInfo);

        /// <summary>
        /// The GetOutgoingTraces
        /// </summary>
        /// <typeparam name="TLinkData"></typeparam>
        /// <param name="paginationInfo">The paginationInfo<see cref="PaginationInfo"/></param>
        /// <returns>The <see cref="TracesState{TState, TLinkData}"/></returns>
        Task<TracesState<TState, TLinkData>> GetOutgoingTracesAsync<TLinkData>(PaginationInfo paginationInfo);

        /// <summary>
        /// The GetBacklogTraces
        /// </summary>
        /// <typeparam name="TLinkData"></typeparam>
        /// <param name="paginationInfo">The paginationInfo<see cref="PaginationInfo"/></param>
        /// <returns>The <see cref="TracesState{TState, TLinkData}"/></returns>
         Task<TracesState<TState, TLinkData>> GetBacklogTracesAsync<TLinkData>(PaginationInfo paginationInfo);

        /// <summary>
        /// The GetAttestationTraces
        /// </summary>
        /// <typeparam name="TLinkData"></typeparam>
        /// <param name="formId">The formId<see cref="string"/></param>
        /// <param name="paginationInfo">The paginationInfo<see cref="PaginationInfo"/></param>
        /// <returns>The <see cref="TracesState{TState, TLinkData}"/></returns>
        Task<TracesState<TState, TLinkData>> GetAttestationTracesAsync<TLinkData>(string formId, PaginationInfo paginationInfo);
    }
}

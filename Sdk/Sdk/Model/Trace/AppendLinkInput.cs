﻿/*
Copyright 2017 Stratumn SAS. All rights reserved.

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

      http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
  limitations under the License.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratumn.Sdk.Model.Trace
{

    /// <summary>
    /// Interface used as argument to append a new link to a trace.
    /// User must provide the trace id, form id and form data.
    /// User can optionally provide the previous link hash, if not it will be fetched
    /// from the API first.
    /// The key difference with the NewTraceInput is that the trace id must be provided.
    /// </summary>
    public class AppendLinkInput<TLinkData>
    {

        private string formId;
        private TLinkData data;
        private string traceId;
        private ITraceLink<TLinkData> prevLink;

        public AppendLinkInput(string formId, TLinkData data, string traceId)
        {
            if (string.ReferenceEquals(formId, null))
            {
                throw new System.ArgumentException("formId cannot be null in AppendLinkInput");
            }

            this.formId = formId;
            this.data = data;
            this.traceId = traceId;
        }


        public AppendLinkInput(string formId, TLinkData data, string traceId, ITraceLink<TLinkData> prevLink)
        {
            if (string.ReferenceEquals(formId, null))
            {
                throw new System.ArgumentException("formId cannot be null in AppendLinkInput");
            }
            this.formId = formId;
            this.data = data;
            this.traceId = traceId;
            this.prevLink = prevLink;
        }

        public string FormId
        {
            get
            {
                return this.formId;
            }
            set
            {
                this.formId = value;
            }
        }


        public TLinkData Data
        {
            get
            {
                return this.data;
            }
            set
            {
                this.data = value;
            }
        }

        public string TraceId
        {
            get
            {
                return this.traceId;
            }
            set
            {
                this.traceId = value;
            }
        }

        public ITraceLink<TLinkData> PrevLink
        {
            get
            {
                return this.prevLink;
            }
            set
            {
                this.prevLink = value;
            }
        }

    }

}

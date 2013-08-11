﻿using System;
using EnsureThat;

namespace MyCouch.Commands
{
#if !WinRT
    [Serializable]
#endif
    public class DocumentExistsCommand : IMyCouchCommand
    {
        public string Id { get; private set; }
        public string Rev { get; private set; }

        public DocumentExistsCommand(string id, string rev = null)
        {
            Ensure.That(id, "id").IsNotNullOrWhiteSpace();

            Id = id;
            Rev = rev;
        }
    }
}
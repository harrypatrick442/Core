using Core;
using Core.Events;
using Core.Interfaces;
using Core.Messages;
using Snippets.WebAPI.WebsocketServers;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Handlers
{

    public delegate void DelegateHandleMessageOfType<TPayload>(TPayload payload);
}
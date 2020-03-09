﻿using System;

/// <summary>
/// Global namespace.
/// </summary>
namespace Task2
{
    /// <summary>
    /// Class with an exception thrown if an already existing element is forced to the list.
    /// </summary>
    public class ElementIsAlreadyPresentException : SystemException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ElementIsAlreadyPresentException"/> class.
        /// </summary>
        public ElementIsAlreadyPresentException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElementIsAlreadyPresentException"/> class.
        /// </summary>
        /// <param name="message">Exception message.</param>
        public ElementIsAlreadyPresentException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElementIsAlreadyPresentException"/> class.
        /// </summary>
        /// <param name="message">Exception message.</param>
        /// <param name="inner">Inner exception.</param>
        public ElementIsAlreadyPresentException(string message, SystemException inner)
            : base (message, inner)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElementIsAlreadyPresentException"/> class.
        /// </summary>
        /// <param name="info">Sarialization information.</param>
        /// <param name="context">Streaming context.</param>
        protected ElementIsAlreadyPresentException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }
    }
}

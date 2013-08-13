﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PdfChannel.cs" company="Jeroen Stemerdink">
//   Copyright© 2013 Jeroen Stemerdink. All Rights Reserved.
// </copyright>
// <summary>
//   
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace EPiServer.Libraries.Output.Channels.Display
{
    using System;
    using System.Linq;
    using System.Web;

    using EPiServer.Web;

    /// <summary>
    /// The json channel.
    /// </summary>
    public class PdfChannel : DisplayChannel
    {
        #region Public Properties

        /// <summary>
        /// Gets the channel name.
        /// </summary>
        public override string ChannelName
        {
            get
            {
                return OutputConstants.PDF;
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The is active.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public override bool IsActive(HttpContextBase context)
        {
            if (context == null)
            {
                return false;
            }

            return ChannelSettings.Instance.EnablePDF && context.Request.AcceptTypes != null &&
                context.Request.AcceptTypes
                    .Any(t => t.Equals(OutputConstants.ApplicationPDF, StringComparison.OrdinalIgnoreCase));
        }

        #endregion
    }
}
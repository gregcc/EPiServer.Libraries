﻿// Copyright© 2014 Jeroen Stemerdink. All Rights Reserved.
// 
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.

using System;
using System.Collections.Generic;

using EPiServer.Cms.Shell.UI.ObjectEditing;
using EPiServer.Core;
using EPiServer.Libraries.Localization.Models;
using EPiServer.Shell.ObjectEditing;
using EPiServer.Shell.ObjectEditing.EditorDescriptors;

namespace EPiServer.Libraries.Localization
{
    [EditorDescriptorRegistration(TargetType = typeof(CategoryList))]
    internal class HideCategoryEditorDescriptor : EditorDescriptor
    {
        #region Public Methods and Operators

        public override void ModifyMetadata(ExtendedMetadata metadata, IEnumerable<Attribute> attributes)
        {
            base.ModifyMetadata(metadata, attributes);

            ContentDataMetadata contentMetadata = (ContentDataMetadata)metadata;
            IContentData ownerContent = contentMetadata.OwnerContent;
            if ((ownerContent is TranslationContainer || ownerContent is CategoryTranslationContainer
                 || ownerContent is TranslationItem) && metadata.PropertyName == "icategorizable_category")
            {
                metadata.ShowForEdit = false;
            }
        }

        #endregion
    }
}
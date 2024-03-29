﻿using System;
using System.Collections;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using Uno.Extensions.Specialized;
using Windows.UI.Xaml.Data;

namespace LaunchShowcase.Converters
{
    /// <summary>
    /// A converter that converts a given <see cref="ICollection"/> to an bool based on the presence of any items in the <see cref="ICollection"/>.
    /// </summary>
    public sealed class CollectionAnyToBoolConverter : IValueConverter
    {
        /// <summary>
        /// Gets whether or not a collection is not empty.
        /// </summary>
        /// <param name="collection">The collection to check.</param>
        /// <returns>Whether or not the colleciton contains any elements</returns>
        [Pure]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Convert(ICollection collection) => collection.Any();

        /// <inheritdoc/>
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is ICollection collection)
            {
                return Convert(collection);
            }

            return false;
        }

        /// <inheritdoc/>
        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}

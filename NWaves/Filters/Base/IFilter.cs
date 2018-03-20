﻿using NWaves.Signals;

namespace NWaves.Filters.Base
{
    /// <summary>
    /// Interface for any kind of filter:
    /// a filter can be applied to any signal transforming it to some output signal
    /// </summary>
    public interface IFilter
    {
        /// <summary>
        /// Method implements offline filtering algorithm
        /// </summary>
        /// <param name="signal">Signal for filtering</param>
        /// <param name="filteringOptions">General filtering strategy</param>
        /// <returns>Filtered signal</returns>
        DiscreteSignal ApplyTo(DiscreteSignal signal, FilteringOptions filteringOptions);

        ///// <summary>
        ///// TODO: method for online filtering (sample-by-sample, buffer-by-buffer)
        ///// </summary>
        ///// <param name="samples"></param>
        ///// <returns></returns>
        //float[] Process(float[] samples)
        //{
        //    throw new NotImplementedException();
        //}
    }
}

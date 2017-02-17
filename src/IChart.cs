using System;
using System.Collections.Generic;

namespace Charts
{
    /// <summary>
    /// Represents a chart
    /// </summary>
    public interface IChart
    {
        /// <summary>
        /// Add a point to the chart
        /// </summary>
        /// <param name="point">The point as KeyValuePair</param>
        void AddPoint(KeyValuePair<object, decimal> point);

        /// <summary>
        /// Add a list of points to the chart
        /// </summary>
        /// <param name="points">A list of points</param>
        void AddPoints(IEnumerable<KeyValuePair<object, decimal>> points);

        /// <summary>
        /// Draws the chart to an image
        /// </summary>
        void Draw();

        /// <summary>
        /// Saves the drawed image to the given file
        /// </summary>
        /// <param name="filename">The file to create</param>
        void SaveTo(String filename);
    }
}
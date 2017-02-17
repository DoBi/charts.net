using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;


namespace Charts
{
    /// <summary>
    /// Abstract base class for many charts
    /// </summary>
    public abstract class Chart : IChart
    {
        /// <summary>
        /// The Bitmap where the chart will be painted
        /// </summary>
        protected Bitmap _bitmap;

        /// <summary>
        /// Add a point to the chart
        /// </summary>
        /// <param name="point">The point as KeyValuePair</param>
        public abstract void AddPoint(KeyValuePair<object, decimal> point);

        /// <summary>
        /// Add a list of points to the chart
        /// </summary>
        /// <param name="points">A list of points</param>
        public abstract void AddPoints(IEnumerable<KeyValuePair<object, decimal>> points);

        /// <summary>
        /// Draws the chart to an image
        /// </summary>
        public abstract void Draw();

        /// <summary>
        /// Saves the drawed image to the given file
        /// </summary>
        /// <param name="filename">The file to create</param>
        public virtual void SaveTo(String filename)
        {
            if (_bitmap != null && !String.IsNullOrWhiteSpace(filename))
            {
                using (var stream = new FileStream(filename, FileMode.OpenOrCreate)) 
                {
                    _bitmap.Save(stream, ImageFormat.Png);
                    stream.Flush();
                }
            }
        }
    }
}
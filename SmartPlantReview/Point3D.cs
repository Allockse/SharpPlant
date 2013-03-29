﻿namespace SharpPlant.SmartPlantReview
{
    /// <summary>
    ///     Provides the structure for a 3D point in SmartPlant Review.
    /// </summary>
    public class Point3D
    {
        #region Point3D Properties

        /// <summary>
        ///     Easting coordinate
        /// </summary>
        public double East { get; set; }

        /// <summary>
        ///     Northing coordinate
        /// </summary>
        public double North { get; set; }

        /// <summary>
        ///     Elevation coordinate
        /// </summary>
        public double Elevation { get; set; }

        #endregion

        // Point3D initializers
        public Point3D()
        {
        }

        public Point3D(double east, double north, double elevation)
        {
            // Set the coordinates
            East = east;
            North = north;
            Elevation = elevation;
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

namespace Epson
    {
    /// <summary>
    /// An EyewearUserCalibrator class for Moverio eyewear.
    /// </summary>
    public class MoverioEyewearUserCalibrator : EyewearUserCalibrator
        {

        /// <summary>
        /// Gets a hint of the maximum size a calibration shape should be drawn
        /// 
        /// Drawing a large calibration shape means the sides of the shape will be near to the sides of the display.
        /// Some eyewear devices have distortion towards the edge of the display.
        /// This API provides a hint as to the maximum size a calibration shape should be drawn.
        /// </summary>
        /// <returns>The maximum scale of the shape in the range 0.0 - 1.0</returns>
        public override float getMaxScaleHint()
            {
            return 1.0f;
            }

        /// <summary>
        /// Gets a hint of the minimum size a calibration shape should be drawn
        /// 
        /// The smaller a calibration shape is drawn the further the user needs to stand away from a target during calibration.
        /// The minimum size that can be drawn is device specific and this API provide a hint as to what minimum scale shape is practical.
        /// </summary>
        /// <returns>The minimum scale of the shape in the range 0.0 - 1.0</returns>
        public override float getMinScaleHint()
            {
            return 0.0f;
            }

        /// <summary>
        /// Gets a projection matrix calibrated for eyewear
        /// 
        /// Calculates and returns a calibrated projection matrix.
        /// init must be called before calling this function.
        /// </summary>
        /// <param name="readings"></param>
        /// <param name="cameraToEyeMatrix"></param>
        /// <param name="projectionMatrix"></param>
        /// <returns></returns>
        public override bool getProjectionMatrix(EyewearDevice.EyewearCalibrationReading[] readings, out Matrix4x4 cameraToEyeMatrix, out Matrix4x4 projectionMatrix)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="surfaceWidth"></param>
        /// <param name="surfaceHeight"></param>
        /// <param name="targetWidth"></param>
        /// <param name="targetHeight"></param>
        /// <returns></returns>
        public override bool init(int surfaceWidth, int surfaceHeight, int targetWidth, int targetHeight)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override bool isStereoStretched()
            {
            throw new NotImplementedException();
            }
        }

    }

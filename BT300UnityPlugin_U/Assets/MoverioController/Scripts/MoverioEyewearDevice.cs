using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

namespace Epson
    {
    /// <summary>
    /// An EyewearDevice class for Moverio eyewear.
    /// </summary>
    public class MoverioEyewearDevice : EyewearDevice
        {

        /// <summary>
        /// Get the calibration profile manager.
        ///
        /// Note: Calibration profiles are only relevant to see-through Eyewear devices.
        /// </summary>
        /// <returns>A reference to the calibration profile manager.</returns>
        public override EyewearCalibrationProfileManager GetCalibrationProfileManager()
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// Returns the correct screen orientation to use when rendering for the eyewear device.
        /// </summary>
        /// <returns>The screen orientation to use when rendering for the eyewear device.</returns>
        public override ScreenOrientation GetScreenOrientation()
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// Gets the calibrator used for creating custom user calibration experiences for see-thru eyewear.
        /// </summary>
        /// <returns>A reference to the calibrator object</returns>
        public override EyewearUserCalibrator GetUserCalibrator()
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// I believe this refers to whether there are two display outputs or if the left/right of the main screen are left/right eye.
        /// </summary>
        /// <returns>Returns true if the Eyewear device display is extended across each eye</returns>
        public override bool IsDisplayExtended()
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// Returns true if the Eyewear device dual display mode is only for OpenGL content.
        /// Some Eyewear devices don't support stereo for 2D (typically Android widget) content. 
        /// On these devices 2D content is rendered to each eye automatically without the need for 
        /// the app to create a split screen view. On such devices this method will return true.
        /// 
        /// Largely irrelevant for Unity-based Moverio apps.
        /// Will need to determine how Android was built for Moverio to determine if this is true outside of Unity.
        /// </summary>
        /// <returns>Returns true of the device is only stereo for OpenGL content. False otherwise.</returns>
        public override bool IsDisplayExtendedGLOnly()
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// Does the device have stereo displays?
        /// </summary>
        /// <returns>Returns true if the Eyewear device has a display for each eye (i.e. stereo), false otherwise.</returns>
        public override bool IsDualDisplay()
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// Does the device currently have predictive tracking enabled?
        /// </summary>
        /// <returns>Returns true if predictive tracking is enabled</returns>
        public override bool IsPredictiveTrackingEnabled()
            {
            return VuforiaConfiguration.Instance.DeviceTracker.PosePrediction;
            }

        /// <summary>
        /// Does the device have a see-thru display?
        /// </summary>
        /// <returns>Returns true if the Eyewear device detected has a see-through display.</returns>
        public override bool IsSeeThru()
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// Switch between 2D (duplication/mono) and 3D (extended/stereo) modes on eyewear device.
        /// </summary>
        /// <param name="enable">set to true to switch to 3D (stereo) mode or false for 2D (mono) mode </param>
        /// <returns>returns true if successful or false if the device doesn't support this operation.</returns>
        public override bool SetDisplayExtended(bool enable)
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// Turn predictive tracking on or off
        ///
        /// Predictive tracking uses device sensors to predict user motion and reduce perceived latency.
        /// By default predictive tracking is enabled on devices that support this enhancement.
        /// </summary>
        /// <param name="enable">set to true to enable predictive tracking or false to disable predictive tracking. </param>
        /// <returns>return true if successful or false if the device doesn't support this operation.</returns>
        public override bool SetPredictiveTracking(bool enable)
            {
            VuforiaConfiguration.Instance.DeviceTracker.PosePrediction = enable;
            return true;
            }

        }

    }

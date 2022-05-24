/*
 * File: BackendCUDA.cs
 * Project: src
 * Created Date: 23/05/2022
 * Author: Shun Suzuki
 * -----
 * Last Modified: 24/05/2022
 * Modified By: Shun Suzuki (suzuki@hapis.k.u-tokyo.ac.jp)
 * -----
 * Copyright (c) 2022 Hapis Lab. All rights reserved.
 * 
 */

using System.Runtime.InteropServices;

namespace AUTD3Sharp
{
    [ComVisible(false)]
    public abstract class BackendCUDA : Backend
    {
        internal BackendCUDA() : base()
        {
            NativeMethods.BackendCUDA.AUTDCUDABackend(out handle);
        }
    }
}
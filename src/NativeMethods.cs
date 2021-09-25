/*
 * File: NativeMethods.cs
 * Project: src
 * Created Date: 08/03/2021
 * Author: Shun Suzuki
 * -----
 * Last Modified: 25/09/2021
 * Modified By: Shun Suzuki (suzuki@hapis.k.u-tokyo.ac.jp)
 * -----
 * Copyright (c) 2021 Hapis Lab. All rights reserved.
 * 
 */


using System;
using System.Runtime.InteropServices;
using System.Text;

namespace AUTD3Sharp
{
    internal static class NativeMethods
    {
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDCreateController(out IntPtr @out);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] [return: MarshalAs(UnmanagedType.U1)] public static extern bool AUTDOpenController(IntPtr handle, IntPtr pLink);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern int AUTDAddDevice(IntPtr handle, double x, double y, double z, double rz1, double ry, double rz2, int gid);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern int AUTDAddDeviceQuaternion(IntPtr handle, double x, double y, double z, double qw, double qx, double qy, double qz, int gid);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern int AUTDDeleteDevice(IntPtr handle, int idx);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDClearDevices(IntPtr handle);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern int AUTDCloseController(IntPtr handle);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern int AUTDClear(IntPtr handle);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDFreeController(IntPtr handle);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] [return: MarshalAs(UnmanagedType.U1)] public static extern bool AUTDIsOpen(IntPtr handle);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] [return: MarshalAs(UnmanagedType.U1)] public static extern bool AUTDIsSilentMode(IntPtr handle);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] [return: MarshalAs(UnmanagedType.U1)] public static extern bool AUTDIsForceFan(IntPtr handle);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] [return: MarshalAs(UnmanagedType.U1)] public static extern bool AUTDIsReadsFPGAInfo(IntPtr handle);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDSetSilentMode(IntPtr handle, [MarshalAs(UnmanagedType.U1)] bool mode);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDSetReadsFPGAInfo(IntPtr handle, [MarshalAs(UnmanagedType.U1)] bool readsFpgaInfo);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDSetForceFan(IntPtr handle, [MarshalAs(UnmanagedType.U1)] bool force);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern double AUTDGetWavelength(IntPtr handle);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern double AUTDGetAttenuation(IntPtr handle);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDSetWavelength(IntPtr handle, double wavelength);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDSetAttenuation(IntPtr handle, double attenuation);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] [return: MarshalAs(UnmanagedType.U1)] public static extern bool AUTDGetFPGAInfo(IntPtr handle, byte[] @out);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] [return: MarshalAs(UnmanagedType.U1)] public static extern int AUTDUpdateCtrlFlags(IntPtr handle);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] [return: MarshalAs(UnmanagedType.U1)] public static extern int AUTDSetOutputDelay(IntPtr handle, byte[,] delay);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] [return: MarshalAs(UnmanagedType.U1)] public static extern int AUTDSetDutyOffset(IntPtr handle, byte[,] offset);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] [return: MarshalAs(UnmanagedType.U1)] public static extern int AUTDSetDelayOffset(IntPtr handle, byte[,] delay, byte[,] offset);
        [DllImport("autd3capi", CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true, CallingConvention = CallingConvention.Cdecl)] public static extern int AUTDGetLastError(StringBuilder? error);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern int AUTDNumDevices(IntPtr handle);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern int AUTDNumTransducers(IntPtr handle);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern int AUTDDeviceIdxForTransIdx(IntPtr handle, int globalTransIdx);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDTransPositionByGlobal(IntPtr handle, int globalTransIdx, out double x, out double y, out double z);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDTransPositionByLocal(IntPtr handle, int deviceIdx, int localTransIdx, out double x, out double y, out double z);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDDeviceXDirection(IntPtr handle, int deviceIdx, out double x, out double y, out double z);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDDeviceYDirection(IntPtr handle, int deviceIdx, out double x, out double y, out double z);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDDeviceZDirection(IntPtr handle, int deviceIdx, out double x, out double y, out double z);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern int AUTDGetFirmwareInfoListPointer(IntPtr handle, out IntPtr @out);
        [DllImport("autd3capi", CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true, CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDGetFirmwareInfo(IntPtr pFirmInfoList, int index, StringBuilder? cpuVer, StringBuilder? fpgaVer);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDFreeFirmwareInfoListPointer(IntPtr pFirmInfoList);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDGainNull(out IntPtr gain);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDGainGrouped(out IntPtr gain);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDGainGroupedAdd(IntPtr groupedGain, int id, IntPtr gain);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDGainFocalPoint(out IntPtr gain, double x, double y, double z, byte duty);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDGainBesselBeam(out IntPtr gain, double x, double y, double z, double nX, double nY, double nZ, double thetaZ, byte duty);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDGainPlaneWave(out IntPtr gain, double nX, double nY, double nZ, byte duty);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDGainCustom(out IntPtr gain, ushort[,] data, int dataLength);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDGainTransducerTest(out IntPtr gain, int idx, byte duty, byte phase);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDDeleteGain(IntPtr gain);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDModulationStatic(out IntPtr mod, byte amp);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDModulationCustom(out IntPtr mod, byte[] buf, uint size);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDModulationSine(out IntPtr mod, int freq, double amp, double offset);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDModulationSinePressure(out IntPtr mod, int freq, double amp, double offset);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDModulationSineLegacy(out IntPtr mod, double freq, double amp, double offset);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDModulationSquare(out IntPtr mod, int freq, byte low, byte high, double duty);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDDeleteModulation(IntPtr mod);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDSequence(out IntPtr @out);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDGainSequence(out IntPtr @out, ushort gainMode);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] [return: MarshalAs(UnmanagedType.U1)] public static extern bool AUTDSequenceAddPoint(IntPtr seq, double x, double y, double z, byte duty);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] [return: MarshalAs(UnmanagedType.U1)] public static extern bool AUTDSequenceAddPoints(IntPtr seq, double[] points, ulong pointsSize, byte[] duties, ulong dutiesSize);

        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] [return: MarshalAs(UnmanagedType.U1)] public static extern bool AUTDSequenceAddGain(IntPtr seq, IntPtr gain);

        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern double AUTDSequenceSetFreq(IntPtr seq, double freq);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern double AUTDSequenceFreq(IntPtr seq);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern uint AUTDSequencePeriod(IntPtr seq);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern uint AUTDSequenceSamplingPeriod(IntPtr seq);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern double AUTDSequenceSamplingFreq(IntPtr seq);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern ushort AUTDSequenceSamplingFreqDiv(IntPtr seq);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDDeleteSequence(IntPtr seq);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDCircumSequence(out IntPtr @out, double x, double y, double z, double nx, double ny, double nz, double radius, ulong n);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern int AUTDStop(IntPtr handle);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern int AUTDPause(IntPtr handle);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern int AUTDResume(IntPtr handle);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern int AUTDSendGain(IntPtr handle, IntPtr gain, bool waitForMsgProcessed);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern int AUTDSendModulation(IntPtr handle, IntPtr mod);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern int AUTDSendGainModulation(IntPtr handle, IntPtr gain, IntPtr mod, bool waitForMsgProcessed);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern int AUTDSendSequence(IntPtr handle, IntPtr seq);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern int AUTDSendGainSequence(IntPtr handle, IntPtr seq);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDSTMController(out IntPtr @out, IntPtr handle);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] [return: MarshalAs(UnmanagedType.U1)] public static extern bool AUTDAddSTMGain(IntPtr handle, IntPtr gain);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] [return: MarshalAs(UnmanagedType.U1)] public static extern bool AUTDStartSTM(IntPtr handle, double freq);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] [return: MarshalAs(UnmanagedType.U1)] public static extern bool AUTDStopSTM(IntPtr handle);
        [DllImport("autd3capi", CallingConvention = CallingConvention.Cdecl)] [return: MarshalAs(UnmanagedType.U1)] public static extern bool AUTDFinishSTM(IntPtr handle);
        [DllImport("autd3capi-holo-gain", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDEigen3Backend(out IntPtr @out);
        [DllImport("autd3capi-holo-gain", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDDeleteBackend(IntPtr backend);
        [DllImport("autd3capi-holo-gain", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDGainHoloSDP(out IntPtr gain, IntPtr backend, double[] points, double[] amps, int size, double alpha, double lambda, ulong repeat, [MarshalAs(UnmanagedType.U1)] bool normalize);
        [DllImport("autd3capi-holo-gain", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDGainHoloEVD(out IntPtr gain, IntPtr backend, double[] points, double[] amps, int size, double gamma, [MarshalAs(UnmanagedType.U1)] bool normalize);
        [DllImport("autd3capi-holo-gain", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDGainHoloNaive(out IntPtr gain, IntPtr backend, double[] points, double[] amps, int size);
        [DllImport("autd3capi-holo-gain", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDGainHoloGS(out IntPtr gain, IntPtr backend, double[] points, double[] amps, int size, ulong repeat);
        [DllImport("autd3capi-holo-gain", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDGainHoloGSPAT(out IntPtr gain, IntPtr backend, double[] points, double[] amps, int size, ulong repeat);
        [DllImport("autd3capi-holo-gain", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDGainHoloLM(out IntPtr gain, IntPtr backend, double[] points, double[] amps, int size, double eps1, double eps2, double tau, ulong kMax, double[]? initial, int initialSize);
        [DllImport("autd3capi-holo-gain", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDGainHoloGaussNewton(out IntPtr gain, IntPtr backend, double[] points, double[] amps, int size, double eps1, double eps2, ulong kMax, double[]? initial, int initialSize);
        [DllImport("autd3capi-holo-gain", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDGainHoloGradientDescent(out IntPtr gain, IntPtr backend, double[] points, double[] amps, int size, double eps, double step, ulong kMax, double[]? initial, int initialSize);
        [DllImport("autd3capi-holo-gain", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDGainHoloAPO(out IntPtr gain, IntPtr backend, double[] points, double[] amps, int size, double eps, double lambda, ulong kMax);
        [DllImport("autd3capi-holo-gain", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDGainHoloGreedy(out IntPtr gain, double[] points, double[] amps, int size, int phaseDiv);
        [DllImport("autd3capi-from-file-modulation", CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true, CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDModulationRawPCM(out IntPtr mod, string fileName, double samplingFreq, ushort modSamplingFreqDiv);
        [DllImport("autd3capi-from-file-modulation", CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true, CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDModulationWav(out IntPtr mod, string fileName, ushort modSamplingFreqDiv);
        [DllImport("autd3capi-soem-link", CallingConvention = CallingConvention.Cdecl)] public static extern int AUTDGetAdapterPointer(out IntPtr @out);
        [DllImport("autd3capi-soem-link", CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true, CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDGetAdapter(IntPtr pAdapter, int index, StringBuilder? desc, StringBuilder? name);
        [DllImport("autd3capi-soem-link", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDFreeAdapterPointer(IntPtr pAdapter);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true)] public delegate void ErrorHandlerDelegate(string str);
        [DllImport("autd3capi-soem-link", CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true, CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDLinkSOEM(out IntPtr @out, string ifname, int deviceNum, uint cycleTicks, IntPtr handler);
        [DllImport("autd3capi-twincat-link", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDLinkTwinCAT(out IntPtr @out);
        [DllImport("autd3capi-remote-twincat-link", CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true, CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDLinkRemoteTwinCAT(out IntPtr @out, string remoteIpAddr, string remoteAmsNetId, string localAmsNetId);
        [DllImport("autd3capi-emulator-link", CallingConvention = CallingConvention.Cdecl)] public static extern void AUTDLinkEmulator(out IntPtr @out, ushort port, IntPtr cnt);
    }
}

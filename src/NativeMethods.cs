// This file is generated by autd_wrapper_generator (https://github.com/shinolab/autd-wrapper-generator)

using System;
using System.Runtime.InteropServices;
using System.Text;

namespace AUTD3Sharp
{
    internal static unsafe class NativeMethods
    {

        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] public static extern void AUTDCreateController(out IntPtr @out);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] [return: MarshalAs(UnmanagedType.U1)] public static extern bool AUTDOpenController(IntPtr handle, IntPtr pLink);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] public static extern int AUTDAddDevice(IntPtr handle, double x, double y, double z, double rz1, double ry, double rz2, int gid);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] public static extern int AUTDAddDeviceQuaternion(IntPtr handle, double x, double y, double z, double qw, double qx, double qy, double qz, int gid);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] public static extern int AUTDDeleteDevice(IntPtr handle, int idx);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] public static extern void AUTDClearDevices(IntPtr handle);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] [return: MarshalAs(UnmanagedType.U1)] public static extern bool AUTDCloseController(IntPtr handle);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] [return: MarshalAs(UnmanagedType.U1)] public static extern bool AUTDClear(IntPtr handle);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] public static extern void AUTDFreeController(IntPtr handle);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] [return: MarshalAs(UnmanagedType.U1)] public static extern bool AUTDIsOpen(IntPtr handle);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] [return: MarshalAs(UnmanagedType.U1)] public static extern bool AUTDIsSilentMode(IntPtr handle);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] [return: MarshalAs(UnmanagedType.U1)] public static extern bool AUTDIsForceFan(IntPtr handle);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] [return: MarshalAs(UnmanagedType.U1)] public static extern bool AUTDIsReadsFPGAInfo(IntPtr handle);
        [DllImport("autd3capi", CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true, CallingConvention = CallingConvention.StdCall)] public static extern void AUTDSetSilentMode(IntPtr handle, [MarshalAs(UnmanagedType.U1)] bool mode);
        [DllImport("autd3capi", CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true, CallingConvention = CallingConvention.StdCall)] public static extern void AUTDSetReadsFPGAInfo(IntPtr handle, [MarshalAs(UnmanagedType.U1)] bool readsFpgaInfo);
        [DllImport("autd3capi", CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true, CallingConvention = CallingConvention.StdCall)] public static extern void AUTDSetForceFan(IntPtr handle, [MarshalAs(UnmanagedType.U1)] bool force);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] public static extern double AUTDGetWavelength(IntPtr handle);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] public static extern double AUTDGetAttenuation(IntPtr handle);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] public static extern void AUTDSetWavelength(IntPtr handle, double wavelength);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] public static extern void AUTDSetAttenuation(IntPtr handle, double attenuation);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] [return: MarshalAs(UnmanagedType.U1)] public static extern bool AUTDGetFPGAInfo(IntPtr handle, byte* @out);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] [return: MarshalAs(UnmanagedType.U1)] public static extern bool AUTDUpdateCtrlFlags(IntPtr handle);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] [return: MarshalAs(UnmanagedType.U1)] public static extern bool AUTDSetOutputDelay(IntPtr handle, byte* delay);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] [return: MarshalAs(UnmanagedType.U1)] public static extern bool AUTDSetDutyOffset(IntPtr handle, byte* offset);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] [return: MarshalAs(UnmanagedType.U1)] public static extern bool AUTDSetDelayOffset(IntPtr handle, byte* delay, byte* offset);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] public static extern int AUTDGetLastError(StringBuilder? error);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] public static extern int AUTDNumDevices(IntPtr handle);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] public static extern int AUTDNumTransducers(IntPtr handle);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] public static extern int AUTDDeviceIdxForTransIdx(IntPtr handle, int globalTransIdx);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] public static extern void AUTDTransPositionByGlobal(IntPtr handle, int globalTransIdx, double* x, double* y, double* z);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] public static extern void AUTDTransPositionByLocal(IntPtr handle, int deviceIdx, int localTransIdx, double* x, double* y, double* z);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] public static extern void AUTDDeviceXDirection(IntPtr handle, int deviceIdx, double* x, double* y, double* z);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] public static extern void AUTDDeviceYDirection(IntPtr handle, int deviceIdx, double* x, double* y, double* z);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] public static extern void AUTDDeviceZDirection(IntPtr handle, int deviceIdx, double* x, double* y, double* z);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] public static extern int AUTDGetFirmwareInfoListPointer(IntPtr handle, out IntPtr @out);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] public static extern void AUTDGetFirmwareInfo(IntPtr pFirmInfoList, int index, StringBuilder? cpuVer, StringBuilder? fpgaVer);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] public static extern void AUTDFreeFirmwareInfoListPointer(IntPtr pFirmInfoList);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] public static extern void AUTDGainNull(out IntPtr gain);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] public static extern void AUTDGainGrouped(out IntPtr gain);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] public static extern void AUTDGainGroupedAdd(IntPtr groupedGain, int id, IntPtr gain);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] public static extern void AUTDGainFocalPoint(out IntPtr gain, double x, double y, double z, byte duty);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] public static extern void AUTDGainBesselBeam(out IntPtr gain, double x, double y, double z, double nX, double nY, double nZ, double thetaZ, byte duty);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] public static extern void AUTDGainPlaneWave(out IntPtr gain, double nX, double nY, double nZ, byte duty);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] public static extern void AUTDGainCustom(out IntPtr gain, ushort* data, int dataLength);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] public static extern void AUTDGainTransducerTest(out IntPtr gain, int idx, byte duty, byte phase);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] public static extern void AUTDDeleteGain(IntPtr gain);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] public static extern void AUTDModulationStatic(out IntPtr mod, byte amp);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] public static extern void AUTDModulationCustom(out IntPtr mod, byte* buf, uint size);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] public static extern void AUTDModulationSine(out IntPtr mod, int freq, double amp, double offset);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] public static extern void AUTDModulationSinePressure(out IntPtr mod, int freq, double amp, double offset);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] public static extern void AUTDModulationSquare(out IntPtr mod, int freq, byte low, byte high);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] public static extern void AUTDDeleteModulation(IntPtr mod);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] public static extern void AUTDSequence(out IntPtr @out);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] [return: MarshalAs(UnmanagedType.U1)] public static extern bool AUTDSequenceAddPoint(IntPtr seq, double x, double y, double z);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] [return: MarshalAs(UnmanagedType.U1)] public static extern bool AUTDSequenceAddPoints(IntPtr seq, double* points, ulong size);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] public static extern double AUTDSequenceSetFreq(IntPtr seq, double freq);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] public static extern double AUTDSequenceFreq(IntPtr seq);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] public static extern uint AUTDSequencePeriod(IntPtr seq);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] public static extern uint AUTDSequenceSamplingPeriod(IntPtr seq);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] public static extern double AUTDSequenceSamplingFreq(IntPtr seq);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] public static extern ushort AUTDSequenceSamplingFreqDiv(IntPtr seq);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] public static extern void AUTDDeleteSequence(IntPtr seq);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] public static extern void AUTDCircumSequence(out IntPtr @out, double x, double y, double z, double nx, double ny, double nz, double radius, ulong n);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] [return: MarshalAs(UnmanagedType.U1)] public static extern bool AUTDStop(IntPtr handle);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] [return: MarshalAs(UnmanagedType.U1)] public static extern bool AUTDPause(IntPtr handle);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] [return: MarshalAs(UnmanagedType.U1)] public static extern bool AUTDResume(IntPtr handle);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] [return: MarshalAs(UnmanagedType.U1)] public static extern bool AUTDSendGain(IntPtr handle, IntPtr gain);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] [return: MarshalAs(UnmanagedType.U1)] public static extern bool AUTDSendModulation(IntPtr handle, IntPtr mod);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] [return: MarshalAs(UnmanagedType.U1)] public static extern bool AUTDSendGainModulation(IntPtr handle, IntPtr gain, IntPtr mod);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] [return: MarshalAs(UnmanagedType.U1)] public static extern bool AUTDSendSequence(IntPtr handle, IntPtr seq);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] public static extern void AUTDSTMController(out IntPtr @out, IntPtr handle);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] [return: MarshalAs(UnmanagedType.U1)] public static extern bool AUTDAddSTMGain(IntPtr handle, IntPtr gain);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] [return: MarshalAs(UnmanagedType.U1)] public static extern bool AUTDStartSTM(IntPtr handle, double freq);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] [return: MarshalAs(UnmanagedType.U1)] public static extern bool AUTDStopSTM(IntPtr handle);
        [DllImport("autd3capi", CallingConvention = CallingConvention.StdCall)] [return: MarshalAs(UnmanagedType.U1)] public static extern bool AUTDFinishSTM(IntPtr handle);
        [DllImport("autd3capi-holo-gain", CallingConvention = CallingConvention.StdCall)] public static extern void AUTDEigen3Backend(out IntPtr @out);
        [DllImport("autd3capi-holo-gain", CallingConvention = CallingConvention.StdCall)] public static extern void AUTDDeleteBackend(IntPtr backend);
        [DllImport("autd3capi-holo-gain", CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true, CallingConvention = CallingConvention.StdCall)] public static extern void AUTDGainHoloSDP(out IntPtr gain, IntPtr backend, double* points, double* amps, int size, double alpha, double lambda, ulong repeat, [MarshalAs(UnmanagedType.U1)] bool normalize);
        [DllImport("autd3capi-holo-gain", CharSet = CharSet.Ansi, BestFitMapping = false, ThrowOnUnmappableChar = true, CallingConvention = CallingConvention.StdCall)] public static extern void AUTDGainHoloEVD(out IntPtr gain, IntPtr backend, double* points, double* amps, int size, double gamma, [MarshalAs(UnmanagedType.U1)] bool normalize);
        [DllImport("autd3capi-holo-gain", CallingConvention = CallingConvention.StdCall)] public static extern void AUTDGainHoloNaive(out IntPtr gain, IntPtr backend, double* points, double* amps, int size);
        [DllImport("autd3capi-holo-gain", CallingConvention = CallingConvention.StdCall)] public static extern void AUTDGainHoloGS(out IntPtr gain, IntPtr backend, double* points, double* amps, int size, ulong repeat);
        [DllImport("autd3capi-holo-gain", CallingConvention = CallingConvention.StdCall)] public static extern void AUTDGainHoloGSPAT(out IntPtr gain, IntPtr backend, double* points, double* amps, int size, ulong repeat);
        [DllImport("autd3capi-holo-gain", CallingConvention = CallingConvention.StdCall)] public static extern void AUTDGainHoloLM(out IntPtr gain, IntPtr backend, double* points, double* amps, int size, double eps1, double eps2, double tau, ulong kMax, double* initial, int initialSize);
        [DllImport("autd3capi-holo-gain", CallingConvention = CallingConvention.StdCall)] public static extern void AUTDGainHoloGreedy(out IntPtr gain, double* points, double* amps, int size, int phaseDiv);
        [DllImport("autd3capi-soem-link", CallingConvention = CallingConvention.StdCall)] public static extern int AUTDGetAdapterPointer(out IntPtr @out);
        [DllImport("autd3capi-soem-link", CallingConvention = CallingConvention.StdCall)] public static extern void AUTDGetAdapter(IntPtr pAdapter, int index, StringBuilder? desc, StringBuilder? name);
        [DllImport("autd3capi-soem-link", CallingConvention = CallingConvention.StdCall)] public static extern void AUTDFreeAdapterPointer(IntPtr pAdapter);
        [DllImport("autd3capi-soem-link", CallingConvention = CallingConvention.StdCall)] public static extern void AUTDLinkSOEM(out IntPtr @out, string ifname, int deviceNum, uint cycleTicks);
        [DllImport("autd3capi-twincat-link", CallingConvention = CallingConvention.StdCall)] public static extern void AUTDLinkTwinCAT(out IntPtr @out);

        [DllImport("autd3capi-emulator-link", CallingConvention = CallingConvention.StdCall)] public static extern void AUTDLinkEmulator(out IntPtr @out, ushort port, IntPtr cnt);
    }
}


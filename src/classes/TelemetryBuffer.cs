using System;

public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    {
        return reading switch
        {
            _ => BitConverter.GetBytes(reading)
        };

    }

    public static long FromBuffer(byte[] buffer)
    {
        throw new NotImplementedException("Please implement the static TelemetryBuffer.FromBuffer() method");
    }
}

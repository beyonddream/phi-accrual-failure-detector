namespace PhiAccrualFailureDetector;

/// <summary>
/// Implementation of 'The Phi Accrual Failure Detector' by Hayashibara et al. as defined in their paper:
/// [https://oneofus.la/have-emacs-will-hack/files/HDY04.pdf]
/// It is based on Akka's implementation in Scala.
/// </summary>
public class PhiAccrualFailureDetector(double threshold, int maxSampleSize, TimeSpan minStdDeviation, TimeSpan acceptableHeartBeatPause, TimeSpan firstHeartbeatEstimate) 
{
      

}

using System;
using UnityEngine;

namespace Training
{
public class Clock : MonoBehaviour
{
  public Transform hour, minute, second;

  public const float hourRot = 360 / 12f;
  public const float minRot = 360 / 60f;
  public const float secRot = 6F;

  private void Update()
  {
    DateTime myTime = DateTime.Now;
    var dTime = Time.deltaTime;
    hour.localRotation = Quaternion.Euler(myTime.Hour * hourRot, 0, 0);
    minute.localRotation = Quaternion.Euler(myTime.Minute * minRot, 0, 0);
    second.localRotation = Quaternion.Euler(
             ((myTime.Second + (myTime.Millisecond / 1000f)/60f)*360f), 0, 0);
  }
}
}

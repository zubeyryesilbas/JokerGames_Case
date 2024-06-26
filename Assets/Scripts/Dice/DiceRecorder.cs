using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;


public class DiceRecorder : MonoBehaviour
{
    public Rigidbody diceRigidbody;
    private List<Vector3> positions = new List<Vector3>();
    private List<Quaternion> rotations = new List<Quaternion>();
    private bool isRecording = false;
    [SerializeField] private string _filePath;
    private bool _canRecord;

    public void StartRecord()
    {
        _canRecord = true;
        isRecording = true;
    }
    void FixedUpdate()
    {
        if (isRecording && _canRecord)
        {
            positions.Add(diceRigidbody.position);
            rotations.Add(diceRigidbody.rotation);
            
        }

        // Stop recording after a certain condition, e.g., dice comes to rest
        if (diceRigidbody.velocity.magnitude < 0.01f && diceRigidbody.angularVelocity.magnitude < 0.01f && _canRecord)
        {
            isRecording = false;
            _canRecord = false;
            WriteDataToFile();
        }
    }

    void WriteDataToFile()
    {
        string filePath = Path.Combine(_filePath+gameObject.name + ".csv");
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("PositionX,PositionY,PositionZ,RotationX,RotationY,RotationZ,RotationW");
            for (int i = 0; i < positions.Count; i++)
            {
                Vector3 pos = positions[i];
                Quaternion rot = rotations[i];
                writer.WriteLine($"{pos.x},{pos.y},{pos.z},{rot.x},{rot.y},{rot.z},{rot.w}");
            }
        }
        AssetDatabase.Refresh();
        Debug.Log("Data written to " + filePath);
    }
}


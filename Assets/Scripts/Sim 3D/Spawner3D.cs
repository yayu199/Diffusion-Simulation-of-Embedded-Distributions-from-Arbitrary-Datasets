using Unity.Mathematics;
using UnityEngine;

public class Spawner3D : MonoBehaviour
{
    public int numParticlesPerAxis=45;
    public Vector3 centre;
    public float size;
    public float sy=0.1f;
    public float3 initialVel;
    public float jitterStrength;
    public bool showSpawnBounds;

	public test2 excelData;

    [Header("Info")]
    public int debug_numParticles;
    public SpawnData GetSpawnData()
    {
        int numPoints = 39818;
        float3[] points = new float3[numPoints];
        float3[] velocities = new float3[numPoints];

        int i = 0;
		string name;
        for (int x = 0; x < numParticlesPerAxis; x++)
        {
            for (int z = 0; z < numParticlesPerAxis; z++)
            {
                name = "y"+z.ToString();
                for (int y = 0; y < excelData.dfg[x].callvar(name); y++)
                {
                    float tx = x / (numParticlesPerAxis - 1f);
                    float tz = z / (numParticlesPerAxis - 1f);
                    float ty = y ;

                    float px = (tx - 0.5f) * size + centre.x;
                    float pz = (tz - 0.5f) * size + centre.z;
                    float py = ty * sy + centre.y;
                    float3 jitter = UnityEngine.Random.insideUnitSphere * jitterStrength;
                    points[i] = new float3(px, py, pz) + jitter;
                    velocities[i] = initialVel;
                    i++;
                }
            }
        }

        return new SpawnData() { points = points, velocities = velocities };
    }

    public struct SpawnData
    {
        public float3[] points;
        public float3[] velocities;
    }

    void OnValidate()
    {
        debug_numParticles = numParticlesPerAxis * numParticlesPerAxis * numParticlesPerAxis;
    }

    void OnDrawGizmos()
    {
        if (showSpawnBounds && !Application.isPlaying)
        {
            Gizmos.color = new Color(1, 1, 0, 0.5f);
            Gizmos.DrawWireCube(centre, Vector3.one * size);
        }
    }
}

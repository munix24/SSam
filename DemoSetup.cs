using UnityEngine;

public class DemoSetup : MonoBehaviour
{
    void Start()
    {
        // Create Ground
        var ground = GameObject.CreatePrimitive(PrimitiveType.Plane);
        ground.transform.position = Vector3.zero;

        // Create Player
        var player = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        player.transform.position = new Vector3(0, 1, 0);
        player.name = "Player";
        player.AddComponent<CharacterController>();
        player.AddComponent<PlayerMovement>();
        player.AddComponent<Health>();

        var cameraGO = new GameObject("Camera");
        cameraGO.transform.SetParent(player.transform);
        cameraGO.transform.localPosition = new Vector3(0, 1.0f, 0);
        cameraGO.AddComponent<Camera>();
        cameraGO.tag = "MainCamera";

        // Create a Weapon script instance on player (optional for further extension)
        player.AddComponent<Weapon>();

        // Spawn Enemies
        for (int i = 0; i < 3; i++)
        {
            var enemy = GameObject.CreatePrimitive(PrimitiveType.Cube);
            enemy.transform.position = new Vector3(5 + i * 3, 0.5f, 5);
            enemy.name = "Enemy" + (i + 1);
            enemy.AddComponent<Enemy>();
        }

        // Add a simple directional light
        var lightGO = new GameObject("Directional Light");
        var light = lightGO.AddComponent<Light>();
        light.type = LightType.Directional;
        light.intensity = 1.0f;
        lightGO.transform.rotation = Quaternion.Euler(50, -30, 0);
    }
}
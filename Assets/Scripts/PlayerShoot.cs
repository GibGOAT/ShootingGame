using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject prefab;
    public GameObject prefab2;
    public Transform bulletTrash;
    public Transform bulletspawn;

    private const float Timer = 0.5f;
    private float _currentTime = 0.5f;
    private bool _canShoot = true;

    private void Update()//timer
    {
        if (!_canShoot)
        {
            _currentTime -= Time.deltaTime;
            if (_currentTime < 0)
            {
                _canShoot = true;
                _currentTime = Timer;
            }
        }
        //bullet1
        if (Input.GetKeyDown(KeyCode.Mouse0) && _canShoot)
        {
            GameObject bullet = Instantiate(prefab, bulletspawn.position, Quaternion.identity);
           
            bullet.transform.SetParent(bulletTrash);
         

            _canShoot = false;
        }

        //bullet2
        if (Input.GetKeyDown(KeyCode.Mouse1) && _canShoot)
        {
            GameObject bullet2 = Instantiate(prefab2, bulletspawn.position, Quaternion.identity);
            bullet2.transform.SetParent(bulletTrash);

        }
    }
}
using Projectiles;
using UnityEngine;

public class MapBound : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out Worm worm))
        {
            worm.Die();
        }

        if(collision.TryGetComponent(out ProjectileView projectileView))
        {
            projectileView.OnCollidedWithMapBound();
        }
    }
}

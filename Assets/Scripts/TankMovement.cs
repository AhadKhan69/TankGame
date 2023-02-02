//using Unity.VisualScripting;
//using UnityEngine;

////public class TankMovement : MonoBehaviour
////{
////    Rigidbody rb;
////    public float distance;
////    public float speed;
////    public float range;

////    private void Start()
////    {
////        rb = GetComponent<Rigidbody>();
////    }
////    private void Update()
////    {
////        if(gameObject.tag == "Player")
////        {
////            rb.velocity = 
////        }
////    }




//    //Basheer Bhai Code
//    //public float movementspeed;
//    //public float distance;
//    //public float range;
//    //public float firerate;
//    //public float bulletspeed;
//    //private rigidbody rb;
//    //public gameobject[] enemies;
//    //public gameobject closestenemy;
//    //start is called before the first frame update
//    //void start()
//    //{
//    //    rb = getcomponent<rigidbody>();
//    //}

//    //update is called once per frame
//    //void update()
//    //{

//    //    if (gameobject.tag == "player")
//    //    {
//    //        closestenemy();
//    //        vector3 dir = gameobject.transform.position - closestenemy.transform.position;
//    //        gameobject.transform.position += new vector3(0, 0, 1 * movementspeed);
//    //        rb.velocity = closestenemy.transform.position * movementspeed;

//    //    }
//    //    else if (gameobject.tag == "enemy")
//    //    {

//    //    }
//    //}
//    //gameobject closestenemy()
//    //{
//    //    if (gameobject.tag == "player")
//    //    {
//    //        enemies = gameobject.findgameobjectswithtag("enemy");
//    //        foreach (gameobject enemy in enemies)
//    //        {
//    //            distance = vector3.distance(gameobject.transform.position, enemy.transform.position);
//    //            if (distance >= range)
//    //            {
//    //                movementspeed = -0.1f;

//    //                closestenemy = enemy;
//    //                transform.lookat(closestenemy.transform.position);
//    //            }
//    //            else
//    //            {
//    //                movementspeed = 0;
//    //            }
//    //        }

//    //    }
//    //    return closestenemy;
//    //}
////}

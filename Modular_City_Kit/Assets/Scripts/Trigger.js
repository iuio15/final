 var colliding : boolean;
 function OnGUI()
 {
     if (colliding)
     {
         GUI.BeginGroup(Rect(Screen.width/2, Screen.height/2, 100, 100));
         GUI.Label(Rect(0,0,100,100), "You have Reached your destination");
         GUI.EndGroup();
     }
 }
 
 function OnTriggerEnter(col : Collider)
 {
     if (col.gameObject.CompareTag("Player"))
     {
         colliding = true;
     }
 }
 
 function OnTriggerExit(col : Collider)
 {
     colliding = false;
 } function OnTriggerEnter()
 {
 	Debug.Log("Player");
 }
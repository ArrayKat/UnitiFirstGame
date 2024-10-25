using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class Enem : MonoBehaviour
{
    public Slider slider; //полоска здоья
    public GameObject player; //объект нашего игрока
    NavMeshAgent agent; //объект бандита
    Transform target; //цель бандита

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        target = player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);
        if ((player.transform.position - agent.transform.position).sqrMagnitude < 10) slider.value -= 10 * Time.deltaTime;
    }
}

using UnityEngine;
using System.Collections;

public class SetColor : MonoBehaviour {

    private GameObject target;
    [SerializeField]
    private Color color;

    void Start () {
        target = this.gameObject;
    }
}

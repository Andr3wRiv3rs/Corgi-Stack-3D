﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lever : Activator {
    private void OnTriggerEnter () {
        active = true;
        transform.GetChild(0).gameObject.SetActive(false);
    }
}

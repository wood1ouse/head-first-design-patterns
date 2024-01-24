﻿namespace ObserverPattern.Observer;

public interface IObserver
{
    public void Update(float temp, float humidity, float pressure);
}
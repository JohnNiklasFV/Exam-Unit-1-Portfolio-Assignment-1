(int steps, int turns)[] movementSequence =
{
    (0, 1),
    (4, 3),
    (4, 1),
    (1, 3),
    (1, 1),
    (3, 3),
    (1, 1),
    (5, 3),
    (3, 1),
    (1, 3),
    (1, 1),
    (2, 1),
    (1, 3),
    (2, 3),
    (5, 1),
    (1, 3),
    (1, 1),
    (2, 3),
    (3, 1),
    (3, 3),
    (1, 1),
    (2, 3),
    (3, 3),
    (3, 1),
    (5, 1),
    (1, 3),
    (4, 1),
    (1, 3),
    (1, 1),
    (1, 3),
    (2, 1),
    (1, 3),
    (4, 1),
    (2, 0),
};

int sequenceIndex = 0;

while (!AtGoal && sequenceIndex < movementSequence.Length)
{
    var sequence = movementSequence[sequenceIndex];

    for (int i = 0; i < sequence.steps; i++)
    {
        if (Peek())
        {
            Move();
        }
    }

    for (int i = 0; i < sequence.turns; i++)
    {
        Turn();
    }
    
    sequenceIndex++;
}

#region Basic functions
// These functions are just her to make your intelisense work. 
// They only have a conceptual function.

void Move()
{
    // Moves the car 1 cell in the direction it is heading. 
}

void Turn()
{
    // Turns the car 90 deg clockwise.
}

bool Peek()
{
    // Returns true if the next cell is open, otherwise false.
    return true; // Just a placeholder value. 
}

bool AtGoal()
{
    // Returns true if the current cell is the goal cell.
    return true; // just a placholder
}

#endregion
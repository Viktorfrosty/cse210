/*
- Added an erase goal option.
- Added a Try-cath block to handle invalid inputs.
- Added a way to return to the main menu in some options.
- Added a handler in case the list goal option is selected but there is no goals in the _goals list.
- added a handler in case that there is not any goal listed and the record and event or erase goals options are selected.
*/

using System;
using QuestSystem;

class Program
{

    static void Main(string[] args)
    {

        GoalManager goalManager = new GoalManager();

        goalManager.Start();

    }

}
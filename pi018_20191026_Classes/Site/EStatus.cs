using System;

namespace pi018_20191026_Classes.Site
{
  /*
  0000 0000 = 0
  0000 0001 = 1 +       0000 0001 << 0
  0000 0010 = 2 +       0000 0001 << 1
  0000 0011 = 3
  0000 0100 = 4 +       0000 0001 << 2 = 0000 0100
  0000 0101 = 5
  0000 0110 = 6
  0000 0111 = 7
  00 | 01 = 01
  10 | 01 = 11 

    0000 0011 | 0000 0010 = 0000 0001
   */

  /// <summary>
  /// Состояние документа (битовое)
  /// </summary>
  [Flags]
  public enum EStatus
  {
    Deleted = 1, // 1 << 0,
    Moderated = 2, // 1 << 1,
    Archived =  4, // 1 << 2,
    ModeratedAndArchived = 
      Moderated | Archived,
    ModeratedAndArchivedAndDeleted = 
      Moderated | Archived | Deleted,
  }
}
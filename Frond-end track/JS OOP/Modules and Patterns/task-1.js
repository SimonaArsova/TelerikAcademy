/* Task Description */
/* 
* Create a module for a Telerik Academy course
  * The course has a title and presentations
    * Each presentation also has a title
    * There is a homework for each presentation
  * There is a set of students listed for the course
    * Each student has firstname, lastname and an ID
      * IDs must be unique integer numbers which are at least 1
  * Each student can submit a homework for each presentation in the course
  * Create method init
    * Accepts a string - course title
    * Accepts an array of strings - presentation titles
    * Throws if there is an invalid title
      * Titles do not start or end with spaces
      * Titles do not have consecutive spaces
      * Titles have at least one character
    * Throws if there are no presentations
  * Create method addStudent which lists a student for the course
    * Accepts a string in the format 'Firstname Lastname'
    * Throws if any of the names are not valid
      * Names start with an upper case letter
      * All other symbols in the name (if any) are lowercase letters
    * Generates a unique student ID and returns it
  * Create method getAllStudents that returns an array of students in the format:
    * {firstname: 'string', lastname: 'string', id: StudentID}
  * Create method submitHomework
    * Accepts studentID and homeworkID
      * homeworkID 1 is for the first presentation
      * homeworkID 2 is for the second one
      * ...
    * Throws if any of the IDs are invalid
  * Create method pushExamResults
    * Accepts an array of items in the format {StudentID: ..., Score: ...}
      * StudentIDs which are not listed get 0 points
    * Throw if there is an invalid StudentID
    * Throw if same StudentID is given more than once ( he tried to cheat (: )
    * Throw if Score is not a number
  * Create method getTopStudents which returns an array of the top 10 performing students
    * Array must be sorted from best to worst
    * If there are less than 10, return them all
    * The final score that is used to calculate the top performing students is done as follows:
      * 75% of the exam result
      * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
*/

function solve() {
  var Course = {
    init: function (title, presentations) {

      function validateTitle(title) {
        if (title.match(/^\s|\s$|\s{2}/) || title == '') {
          throw '';
        }
      }

      validateTitle(title);

      for (let presentationTitle of presentations) {
        validateTitle(presentationTitle);
      }

      if (presentations.length === 0) {
        throw '';
      }

      this.students = [];
      this.homeworks = [];
      let presentation = {};

      for (let i = 0; i < presentations.length; i += 1) {
        presentation.id = i + 1;
        presentation.title = presentations[i];
        this.homeworks.push(presentation);
      }
      return this;
    },

    addStudent: function (name) {
      if (!name.match(/^[A-Z][a-z]*\s[A-Z][a-z]*$/)) {
        throw '';
      }

      let student = {};
      student.id = this.students.length + 1;
      student.firstname = name.split(' ')[0];
      student.lastname = name.split(' ')[1];

      this.students.push(student);
      return student.id;
    },

    getAllStudents: function () {
      return this.students;
    },

    submitHomework: function (studentID, homeworkID) {
      if (!this.students.some(student => student.id === studentID)) {
        throw Error('Invalid StudentID');
      }

      if (!this.homeworks.some(homework => homework.id === homeworkID)) {
        throw Error('Invalid HomeworkID');
      }
    },

    pushExamResults: function (results) {

      if (!Array.isArray(results)) {
        throw '';
      }

      results.forEach(function (result) {
        if (Number.isNaN(Number(result.score))) {
          throw '';
        }
        if (Number.isNaN(Number(result.StudentID))) {
          throw '';
        }
      });

      for (let i = 0; i < results.length; i += 1) {
        if (results[i].StudentID < this.students[0].id) {
          throw Error(`Id < first student's number`);
        }

        if (results[i].StudentID > this.students.length) {
          throw Error('Id > students number');
        }
      }

      for (let i = 1; i < results.length; i += 1) {
        if (results[i].StudentID === results[0].StudentID) {
          throw Error('Id duplication');
        }
      }
    },

    getTopStudents: function () {
    }
  };

  return Course;
}


module.exports = solve;

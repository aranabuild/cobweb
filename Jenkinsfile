pipeline {
  agent any
  stages {
    stage('NuGet Restore') {
      steps {
        powershell 'nuget restore ./src/Cobweb.sln'
      }
    }
    stage('') {
      steps {
        bat '\\"${tool \'MSBuild\'}\\" ./src/Cobweb.sln /p:Configuration=Release'
      }
    }
  }
}
pipeline {
  agent any
  tools {
    msbuild 'MSBuild'
  }
  stages {
    stage('Build') {
      steps {
        bat "msbuild.exe ./src/Cobweb.sln /p:Configuration=Release"
      }
    }
  }
}

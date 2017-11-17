pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        bat "\"${tool name: 'MSBuild', type: 'msbuild'}\" ./src/Cobweb.sln /p:Configuration=Release"
      }
    }
  }
}

# ===============================
# Git Push Automation Script
# Repo: .NET-Practice
# ===============================

# Stop script on error
$ErrorActionPreference = "Stop"

# GitHub repo URL
$repoUrl = "https://github.com/Gaurav822131/.NET-Practice.git"

Write-Host "Initializing Git Repository..." -ForegroundColor Cyan

# Initialize git if not already
if (!(Test-Path ".git")) {
    git init
}

# Add remote if not exists
$remoteExists = git remote | Select-String "origin"
if (-not $remoteExists) {
    git remote add origin $repoUrl
}

Write-Host "Adding files..." -ForegroundColor Cyan
git add .

Write-Host "Committing changes..." -ForegroundColor Cyan
git commit -m "assignment"

Write-Host "Setting branch to main..." -ForegroundColor Cyan
git branch -M main

Write-Host "Pushing code to GitHub..." -ForegroundColor Green
git push -u origin main

Write-Host "✅ Code pushed successfully!" -ForegroundColor Green
